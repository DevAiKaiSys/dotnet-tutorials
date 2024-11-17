﻿global using System.Collections.Immutable;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using TubePlayer.Models;
global using TubePlayer.Presentation;
global using ApplicationExecutionState = Windows.ApplicationModel.Activation.ApplicationExecutionState;
global using Color = Windows.UI.Color;
global using System.Text.Json;
global using TubePlayer.Business;
global using TubePlayer.Services.Models;
using Uno.Extensions.Reactive.Config;

[assembly: BindableGenerationTool(3)]
