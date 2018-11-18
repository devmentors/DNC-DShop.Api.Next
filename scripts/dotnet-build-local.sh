#!/bin/bash
dotnet build --source "https://api.nuget.org/v3/index.json" --source "https://www.myget.org/F/ngate/api/v3/index.json" --no-cache 