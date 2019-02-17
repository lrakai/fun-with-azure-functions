# fun-with-azure-functions

Lab environment for working with Azure functions (consumption plan)

![Final Environment](https://user-images.githubusercontent.com/3911650/52908811-565df180-323a-11e9-9fba-7bf350839966.png)

## Getting Started

An Azure RM template is included in `infrastructure/` to create the environment:

<a href="http://armviz.io/#/?load=https%3A%2F%2Fraw.githubusercontent.com%2Flrakai%2Ffun-with-azure-functions%2Fmaster%2Finfrastructure%2Farm-template.json">
    <img src="https://camo.githubusercontent.com/536ab4f9bc823c2e0ce72fb610aafda57d8c6c12/687474703a2f2f61726d76697a2e696f2f76697375616c697a65627574746f6e2e706e67" data-canonical-src="http://armviz.io/visualizebutton.png" style="max-width:100%;">
</a> 

Using Azure PowerShell, do the following to provision the resources:

```ps1
.\New-Lab.ps1
```

Alternatively, you can perform a one-click deploy with the following button:

<a href="https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Flrakai%2Ffun-with-azure-functions%2Fmaster%2Finfrastructure%2Farm-template.json">
    <img src="https://camo.githubusercontent.com/9285dd3998997a0835869065bb15e5d500475034/687474703a2f2f617a7572656465706c6f792e6e65742f6465706c6f79627574746f6e2e706e67" data-canonical-src="http://azuredeploy.net/deploybutton.png" style="max-width:100%;">
</a>

## Following Along

1. Create an Azure Function App using the __Consumption Plan__ with Application Insights enabled

1. Create an Azure Function using the __C# Azure Blob Storage Trigger__ template

1. Replace the contents of the `run.csx` file with `src/function.csx`

1. Replace the contents of the `function.json` file with `src/function.json`

1. Create an Azure Table named `uploads` in the storage account created by the Lab's ARM template

1. Upload a file to the `uploads` blob container

1. Observe the corresponding entity created in the `uploads` table

1. Upload more files and observe the logs and metrics in Application Insights

## Tearing Down

When finished, remove the Azure resources with:

```ps1
.\Remove-Lab.ps1
```