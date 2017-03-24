namespace JasonetteDotNet
{
    public abstract class JasonetteTitle : JasonetteEntity
    {
        public abstract string Type { get; }

        public static implicit operator JasonetteTitle(string text)
        {
            return new JasonetteLabelTitle(text);
        }
    }
}
