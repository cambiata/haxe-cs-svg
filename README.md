# haxe-cs-svg
Simple Haxe C# example of rendering svg to a bitmap

Current versions: Haxe 3.2, hxcs 3.2.0

## Mac setup

Make sure that you have [mono](http://www.mono-project.com/download/#download-mac) installed. 

Typically, the mono installpath should be ```/Library/Frameworks/Mono.framework/```.
The mono compiler (mcs) should be found at ```/Library/Frameworks/Mono.framework/Versions/Current/bin/mcs```

The referenced libraries used in this example (System.Drawing.dll and System.Xml.dll) should be found at the following paths:

* /Library/Frameworks/Mono.framework/Libraries/mono/4.0/System.Drawing.dll
* /Library/Frameworks/Mono.framework/Libraries/mono/4.0/System.Xml.dll

### Compiling/running on Mac/OSX

Navigate to the haxe-cs-svg directory and run the following command:
```> haxe build-and-run-mac.hxml```

Apart from the standard two-step process of 1) Haxe compiling the .cs sourcecode, and 2) running the mono compiler to compile the .cs sourcecode to the output Main.exe, this build-and-run-mac.hxml script also does the following:

* remove System.Drawing.dll and System.Xml.dll from the bin-mac/bin/ folder. (If they are not removed, running the .exe will cause an "Unhandled Exception: System.InvalidProgramException: Invalid IL code in System.Drawing.Graphics" - at least at my machine.)
* running the output exe by navigating into the bin-mac/bin/ folder and kicking off ```mono Main.exe```.

The program shold run and output a svgExample.png in the bin-mac/bin folder.



