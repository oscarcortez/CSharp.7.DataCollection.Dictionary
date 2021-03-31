# CSharp.7.DataCollection.Dictionary

trata de un arreglo clave valor
```csharp
Dictionary<string, string> openWith = new Dictionary<string, string>();
```

clave y valor puede ser de cualquier tipo y diferentes entre si

para agregar un keyValuePair:
```csharp
openWith.Add("bmp", "paint.exe");
openWith.Add("dib", "paint.exe");
openWith.Add("rtf", "wordpad.exe");
```

guardar las claves en un arreglo: 
```csharp
Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;
```

remover un keyValue:
```csharp
openWith.Remove("doc");
```

obtener un value si es que existe la clave
```csharp
openWith.TryGetValue("doc", out string docResult);
```

tambien existe el tryAdd que es como un add pero con excepcion integrado
