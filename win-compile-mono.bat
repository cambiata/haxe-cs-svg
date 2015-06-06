mkdir bin-win\bin\

copy Svg.dll bin-win\bin\Svg.dll

cd bin-win\

"C:\Program Files (x86)\Mono\bin\mcs"  /nologo /optimize+ /debug- /unsafe- /warn:0 /out:bin/Main.exe /target:exe /main:EntryPoint__Main /reference:System.Drawing.dll /reference:System.Xml.dll /reference:../Svg.dll src\cs\Boot.cs src\Std.cs src\cs\internal\Null.cs src\haxe\Log.cs src\Array.cs src\cs\internal\Function.cs src\Type.cs src\Reflect.cs src\cs\internal\Iterator.cs src\cs\internal\StringExt.cs src\cs\internal\Runtime.cs src\cs\Lib.cs src\cs\internal\HxObject.cs src\cs\internal\Exceptions.cs src\haxe\lang\FieldLookup.cs src\Main.cs

