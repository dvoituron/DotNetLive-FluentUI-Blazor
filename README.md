# DotNetLive - FluentUI Blazor v5 Demo

This repository contains a step-by-step demo project showing how to build a
Blazor application using **[Microsoft FluentUI Blazor v5](https://v5.fluentui-blazor.net/)**.

The code is explained during the **.NET Live** video session available on YouTube:
[youtube.com/live/CRVLURJjFBk](https://www.youtube.com/live/CRVLURJjFBk).

Each step is stored on its own Git branch, so you can checkout any branch to
see the project state at that point in the tutorial.

## Project

The demo lives in the [DemoFluentUI](DemoFluentUI) folder and targets **.NET 10** with
**Microsoft.FluentUI.AspNetCore.Components v5**.

> Update (September 2026): the final v5 release of Fluent UI Blazor is now published on NuGet, so the package commands can be simplified and no longer require the preview feed:
>
> ```powershell
> dotnet add package Microsoft.FluentUI.AspNetCore.Components
> dotnet add package Microsoft.FluentUI.AspNetCore.Components.Charts
> ```

To run the project:

```powershell
cd DemoFluentUI
dotnet run
```

## Steps

The following branches walk through the project, one feature at a time.

| #  | Step | Branch |
|----|------|--------|
| 01 | Empty Blazor project | [steps/01-empty-blazor](https://github.com/dvoituron/DotNetLive-FluentUI-Blazor/tree/steps/01-empty-blazor) |
| 02 | FluentUI installation | [steps/02-installation](https://github.com/dvoituron/DotNetLive-FluentUI-Blazor/tree/steps/02-installation) |
| 03 | Layout | [steps/03-layout](https://github.com/dvoituron/DotNetLive-FluentUI-Blazor/tree/steps/03-layout) |
| 04 | Basic components | [steps/04-basic-components](https://github.com/dvoituron/DotNetLive-FluentUI-Blazor/tree/steps/04-basic-components) |
| 05 | List | [steps/05-list](https://github.com/dvoituron/DotNetLive-FluentUI-Blazor/tree/steps/05-list) |
| 06 | Dialog | [steps/06-dialog](https://github.com/dvoituron/DotNetLive-FluentUI-Blazor/tree/steps/06-dialog) |
| 07 | File input | [steps/07-fileinput](https://github.com/dvoituron/DotNetLive-FluentUI-Blazor/tree/steps/07-fileinput) |
| 08 | Default values | [steps/08-default-values](https://github.com/dvoituron/DotNetLive-FluentUI-Blazor/tree/steps/08-default-values) |
| 09 | DataGrid | [steps/09-datagrid](https://github.com/dvoituron/DotNetLive-FluentUI-Blazor/tree/steps/09-datagrid) |
| 10 | Theme | [steps/10-theme](https://github.com/dvoituron/DotNetLive-FluentUI-Blazor/tree/steps/10-theme) |
| 11 | Charts | [steps/11-charts](https://github.com/dvoituron/DotNetLive-FluentUI-Blazor/tree/steps/11-charts) |

To switch to a specific step:

```powershell
git checkout steps/03-layout
```

## Resources

- [FluentUI Blazor documentation](https://v5.fluentui-blazor.net/)
- [FluentUI Blazor GitHub repository](https://github.com/microsoft/fluentui-blazor)
- [Blazor documentation](https://learn.microsoft.com/aspnet/core/blazor/)

## License

See [LICENSE](LICENSE).
