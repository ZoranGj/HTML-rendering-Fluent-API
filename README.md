# HTML-rendering-Fluent-API

Usage example:
```
var html = Body().Elements(
                Container().Elements(
                        Container().Elements(
                            Input(),
                            Input()),
                        Input()),
                Container().Elements(
                        Input()));
```
                                    

Result:
```
<body>
    <div>
      <div>
        <input type="text"/>
        <input type="text"/>
      </div>
      <input type="text"/>
    </div>
    <div>
      <input type="text"/>
    </div>
</body>
```
