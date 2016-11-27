.DEFAULT_GOAL := build
include config.mk

mindi-link:
	rm -rf mindi
	ln -s $(MINDI_PATH) mindi
    
restore:
	mono nuget.exe restore

rebuild:
	xbuild /t:rebuild mindi-demo.sln

build:
	xbuild /t:build mindi-demo.sln

alias:
	alias demo="mono bin/Debug/mindi_demo.exe"

