# Exercise 2 - Shared Components

## Commands
```
dotnet new razorclasslib –n InfoPage
cd InfoPage
dotnet new razorcomponent –n EnvInfo
cd ../server
dotnet add reference ../InfoPage
```

## UI - PrintInfo.razor
```
<EnvInfo></EnvInfo>
```

## Code
```
@page "/PrintInfo"
@using InfoPage.Components
```