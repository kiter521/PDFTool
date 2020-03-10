# !/usr/bin/env python
# -*- coding: utf-8-*-
# pylint:disable=invalid-name

import sys

from PyPDF2 import PdfFileReader, PdfFileWriter

#将pdf文档全部分割
def SplitAll(pfile, wr):
    pdf = PdfFileReader(pfile)
    for idx in range(pdf.getNumPages()):
        wr.addPage(pdf.getPage(idx))
        with open(str(idx + 1) + '_split.pdf', 'wb') as out:
            wr.write(out)
            wr = PdfFileWriter()
 
#将指定页分割成pdf文档
def SplitSpec(pfile, wr, page):
    pdf = PdfFileReader(pfile)
    if int(page) > pdf.getNumPages():
        print('out of pages!!')
        sys.exit()
    wr.addPage(pdf.getPage(int(page) - 1))
    with open(str(page) + '_split.pdf', 'wb') as out:
        wr.write(out)


#将指定范围的页分割成pdf文档
def SplitRange(pfile, wr, start, end):
    pdf = PdfFileReader(pfile)
    if int(start) < 0 and int(end) > pdf.getNumPages():
        print('Range is wrong !!!')
        sys.exit()

    for idx in range(int(start), int(end) + 1):
        wr.addPage(pdf.getPage(idx - 1))

    with open (str(start) + "-" + str(end) + '_split.pdf', 'wb') as out:
            wr.write(out)

#将指定范围的页分割成单独的pdf文档
def SplitRangeSig(pfile, wr, start, end):
    pdf = PdfFileReader(pfile)

    if int(start) < 0 and int(end) > pdf.getNumPages():
        print('Range is wrong !!!')
        sys.exit()

    for idx in range(int(start), int(end) + 1):
        wr.addPage(pdf.getPage(idx - 1))
        with open(str(idx) + '_split.pdf', 'wb') as out:
            wr.write(out)
            wr = PdfFileWriter()

def MergePdf(wr):
    for idx in range(0, sys.argv.count()):
        pdf = PdfFileReader(sys.argv[idx + 2])
        for idy in range(pdf.getNumPages()):
            wr.addPage(pdf.getPage(idy))

    with open('newfile.pdf', 'wb') as out:
        wr.write(out)

def MergeSpecPdf(writer):
    
'''
    参数说明：
    argv --
      0：程序名
      1：文件目录及文件名
      2：指定操作
         a -- 分割全部
         s -- 分割指定页
         r -- 分割指定范围
         rs-- 分割指定范围为单独pdf
         m -- 合并指定的pdf文档
         ms-- 合并一个pdf文件中的指定页数
      3：可选参数
         argv[2]==a :不指定
         argv[2]==s : 指定的页数
         argv[2]==r / rs: 指定范围的开始页数
      4：可选参数
         argv[2]==r / rs: 指定范围的结束页数
'''

if __name__ == "__main__":
    fileName = sys.argv[1]
    writer = PdfFileWriter()
    #deal
    if sys.argv[2] == 'a':
        SplitAll(fileName, writer)
    elif sys.argv[2] == 's':
        SplitSpec(fileName, writer, sys.argv[3])
    elif sys.argv[2] == 'r':
        SplitRange(fileName, writer, sys.argv[3], sys.argv[4])
    elif sys.argv[2] == 'rs':
        SplitRangeSig(fileName, writer, sys.argv[3], sys.argv[4])
    elif sys.argv[1] == 'm':
        MergePdf(writer)
    elif sys.argv[1] == 'ms':
        MergeSpecPdf(writer)
    else:
        #error
        print('should not come here!')
    print('Done Successful!')
