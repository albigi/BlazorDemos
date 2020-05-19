# Exercise 3 - Blazor in Razor

## Create a Razor Pages app
```
dotnet new webapp -n razorapp
cd razorapp
dotnet add reference ../InfoPage
cd Pages
dotnet new razorpage -n PrintInfo
```

## Prepare the app
Follow the link to the docs

## Add a component
Follow the link to the docs or use this snippet

```
@page
@model razorapp.Pages.PrintInfoModel
@using InfoPage.Components
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers


<component type="typeof(InfoPage.Components.EnvInfo)" render-mode="ServerPrerendered" />

@{
}

```

## Create a navigation link in the default layout
The link mast point at the asp-page /PrintInfo