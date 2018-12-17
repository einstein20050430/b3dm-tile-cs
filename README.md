# b3dm-cs

.NET Standard 2.0 Library for (de)serializing B3dm files to/from glTF

[![NuGet Status](http://img.shields.io/nuget/v/b3dm-tile.svg?style=flat)](https://www.nuget.org/packages/b3dm-tile/)

## Sample code:

```
string path = "testfixtures/1311.b3dm";
var memoryStream = new MemoryStream(File.ReadAllBytes(path));
var b3dm = B3dmParser.ParseB3dm(memoryStream);
File.WriteAllBytes("test.gltf", b3dm.GlbData);
```

Example glTF viewer for test.gltf: https://gltf-viewer.donmccurdy.com/

<img src="gltf.png"/>

## Dependencies

NETStandard.Library 2.0.3
