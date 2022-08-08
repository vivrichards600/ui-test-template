# ui-test-template

Example UI journey tests using C#.

The example test within this repository runs against the [Sweet Shop Project|https://sweetshop.netlify.app/].

This repository is configured to perform UI testing using Chrome. Chrome is
specified within `public void Setup()` of `Browser.cs`.

This project makes use of the PageObjectModel and uses fluent chaining.

## Generating a new UI Test project using this template
This repository can be used to quickly create a UI test suite.

To create a new UI Test project using this repository as a template, click on
`Use this template`.

You DO NOT need to clone this project to generate a UI test project from this
template. [Further information on using GitHub templates can be found here|https://docs.github.com/en/repositories/creating-and-managing-repositories/creating-a-repository-from-a-template].

### How to use a newly generated repository from this template

Once you've created a new UI test repository by cloning this repository there are a few things you might wish to do:

* Run the example test provided as part of this project within `ExampleTest.cs` to ensure everything compiles and the example test passes
* Rename the ui-test-template.csproj by right clicking it, choosing `Rename...` and specifiying a new name
* Rename the ui-test-template.sln by right clicking it, choosing `Rename...` and specifiying a new name
* Replacing `ui-test-template` at the top of the README.md to specifiy your repositories name as well as specifying any other useful information