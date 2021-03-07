using System;

namespace Slooh.Explorer.Filtering
{
    enum FilterMode
    {
        [Text("=")]
        Equals,
        [Text("\u2260")]
        NotEquals, 
        [Text("\u2194")]
        Contains,
        [Text("|*")]
        Begins,
        [Text("*|")]
        Ends,
        [Text("<")]
        Less,
        [Text("\u2264")]
        LessEqual,
        [Text(">")]
        Greater,
        [Text("\u2265")]
        GreaterEqual,
        [Text("*?")]
        Pattern,
        [Text(".*")]
        Expression,
        [Text("\u2026")]
        None,
    }

    [System.AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    sealed class TextAttribute : Attribute
    {
        public TextAttribute(string text)
        {
            Text = text;
        }

        public string Text { get; }        
    }
}
