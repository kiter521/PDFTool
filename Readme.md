#######################################
###########PDFTool 使用说明#############
#######################################

***************************************
***************************************
PDF工具测试版，目前版本号：V0.2测试版
目前UI功能还在测试中，如有好的建议请反馈至<hufeixiang@cn.fujitsu.com>
使用前请先安装Python3，并配置环境变量。
安装及配置方法请参照：
<https://blog.csdn.net/piaoling691/article/details/80710802>
***************************************
***************************************

V0.1测试版本
  增加功能：
  1.将选定的PDF文件拆分为单页
    使用命令：python PDFTool.py 文件名.pdf a

  2.将选定的PDF文件按照指定页分割
    使用命令：python PDFTool.py 文件名.pdf s 指定页

  3.将指定范围内的PDF文件分割成一个PDF文件
    使用命令：python PDFTool.py 文件名.pdf r 指定开始页 指定结束页

  4.将指定范围内的PDF文件分割成单个的PDF文件
    使用命令：python PDFTool.py 文件名.pdf rs 指定开始页 指定结束页
	
V0.2测试版
  1）追加UI画面，使用说明：
    1.指定页数时，以空格区分，如2 3 4 6
	2.指定页数时，目前最大支持30页（一次性输入过多容易混乱）
	3.指定的pdf文件时，文件名中不可以包含空格
	  
  2）
  Python修正机能：
  1.将选定的PDF文件拆分为单页
    使用命令：python PDFTool.py -a 文件名.pdf

  2.将选定的PDF文件按照指定页分割
    使用命令：python PDFTool.py -s 文件名.pdf 指定页

  3.将指定范围内的PDF文件分割成一个PDF文件
    使用命令：python PDFTool.py -r 文件名.pdf 指定开始页 指定结束页

  4.将指定范围内的PDF文件分割成单个的PDF文件
    使用命令：python PDFTool.py -rs 文件名.pdf 指定开始页 指定结束页
	
  Python追加机能
  1.将多个pdf文件合并成一个文件
    使用命令：python PDFTool.py -m 文件名1.pdf 文件名2.pdf 。。。。。
  2.将一个pdf文件中的指定页合并成一个文件输出
    使用命令：python PDFTool.py -ms 文件名.pdf 2 3 。。。。