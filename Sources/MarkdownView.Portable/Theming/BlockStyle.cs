﻿using Xamarin.Forms;

namespace MarkdownView.Theming
{
    public class BlockStyle : IBlockStyle
    {
        public FontAttributes Attributes { get; set; } = FontAttributes.None;

        public float FontSize { get; set; } = 12;

        public Color ForegroundColor { get; set; } = Color.Black;

        public Color BackgroundColor { get; set; } = Color.Transparent;

        public Color BorderColor { get; set; }

        public float BorderSize { get; set; }

        public string FontFamily { get; set; }

        public string FontFamilyItalic { get; set; }

        public string FontFamilyBold { get; set; }
    }
}