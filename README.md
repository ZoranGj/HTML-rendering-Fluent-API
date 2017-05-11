# HTML-rendering-Fluent-API

Fluent API for generating HTML from C#. 
The library is published as a nuget package and can be found here: https://www.nuget.org/packages/HTMLGeneratorAPI/.

## Getting Started

These instructions will lead you to install the library in your project and use it for your development purposes.

### Prerequisites

The project where the library will be used to have target .NET framework at least version 4.6.


### Installing and usage

#### 1. Install the package
To install the library, run the following command in the Package Manager Console:
```
Install-Package HTMLGeneratorAPI
```

#### 2. Import the TagGenerator methods.
Import TagGenerator in the class where the HTML generating will take place:
```
using static HtmlGenerator.TagGenerator;
```

#### 3. Start generating HTML!
Example of generating an HTML form with several elements:
```
var html = Form().Elements(Container().Class("well").Style("padding", "20px;").Background("#f2f2f2").Elements(
                Container().Class("col-md-12").Elements(
                        Label("Form label").Style("margin-bottom", "12px;").Font(24)),
                Container().Class("col-md-6").Elements(
                        Container().Class("form-group").Elements(
                            Label("Input 1"),
                            Input().Class("form-control").Placeholder("Input 1..."),
                            Label("Input 2"),
                            Input().Class("form-control").Placeholder("Input 2...")),
                        Label("Input 3").Color("green"),
                        Input().Class("form-control").Placeholder("Input 3...")),
                Container().Class("col-md-6 form-group").Elements(
                        Label("Input 4").Color("green"),
                        Input().Class("form-control").Placeholder("Input 4..."))));
```

Result:
```
<form>
  <div class="well" style="padding: 20px;background: #f2f2f2">
  <div class="col-md-12">
    <label style="margin-bottom: 12px;font-size: 24px">Form label</label>
  </div>

  <div class="col-md-6">
    <div class="form-group">
      <label>Input 1</label>
      <input type="text" class="form-control" placeholder="Input 1...">

      <label>Input 2</label>
      <input type="text" class="form-control" placeholder="Input 2...">
    </div>

    <label style="color: green">Input 3</label>
    <input type="text" class="form-control" placeholder="">
  </div>

  <div class="col-md-6 form-group">
    <label style="color: green">Input 4</label>
    <input type="text" class="form-control" placeholder="">
    </div>
  </div>
</form>
```
