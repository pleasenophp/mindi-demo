.DEFAULT_GOAL := build
include config.mk

import:
	rm -rf mindi
	mkdir mindi
	cp $(MINDI_PATH)/mindi-interop.dll mindi/
	cp $(MINDI_PATH)/mindi.dll mindi/
	cp $(MINDI_PATH)/minioc.dll mindi/
    
restore:
	mono nuget.exe restore

rebuild: import
	xbuild /t:rebuild mindi-demo.sln

build: import
	xbuild /t:build mindi-demo.sln

style:
	astyle --recursive --options=style.astyle "*.cs"

