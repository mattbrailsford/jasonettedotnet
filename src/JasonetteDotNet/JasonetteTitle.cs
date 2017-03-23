namespace JasonetteDotNet
{
    public abstract class JasonetteTitle
    {
        public abstract string Type { get; }

        public static implicit operator JasonetteTitle(string text)
        {
            return new JasonetteLabelTitle(text);
        }
    }
}
