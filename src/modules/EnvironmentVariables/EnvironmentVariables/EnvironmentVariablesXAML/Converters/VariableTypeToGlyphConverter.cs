﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using EnvironmentVariables.Models;
using Microsoft.UI.Xaml.Data;

namespace EnvironmentVariables.Converters;

public class VariableTypeToGlyphConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        var type = (VariablesSetType)value;
        return type switch
        {
            VariablesSetType.User => "\uE77B",
            VariablesSetType.System => "\uE977",
            VariablesSetType.Profile => "\uEDE3",
            _ => throw new NotImplementedException(),
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
