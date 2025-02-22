# FBX Parser

FBX file (```.fbx```) low-level Parser in C#.

FBX is just a hierarchical structual format like json(```.json```), xml(```xml```), and so on.

Generally, fbx file is for 3D-model file format, but this parser is not only for 3D-model file, just parse hierarchical structure of ```.fbx``` into C#-class.

## Supported Format Version

```.fbx``` file has some format version.

- [x] ver7.4
- [x] ver7.5
- [ ] Any other versions (***NOT SUPPORTED of this parser***)

## How to Use

Parsing is very easy.

```cs
using Fbx;
// ~~~~~~~~~

var parser = FbxParser();
var fbxObj = parser.Parse("somefile.fbx");
```

For debugging or watching its hierarchical structure, use following.

```cs
string dumped = fbxObj.Dump();
Debug.WriteLine(dumped);
```

## License

This is licensed under MIT.

## Author

ikorin24 ([github](https://github.com/ikorin24))
