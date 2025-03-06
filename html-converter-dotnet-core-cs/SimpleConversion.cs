﻿using System;
using ceTe.DynamicPDF.HtmlConverter;

namespace html_converter_dotnet_core_cs
{
    class SimpleConversion
    {
        public static void Run()
        {
            // Convert HTML to PDF with the default conversion options
            Converter.Convert(new Uri("https://www.google.com"),Util.GetPath("Output/SimpleConversion.pdf"));
        }
    }
}
