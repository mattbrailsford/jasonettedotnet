namespace JasonetteDotNet
{
    public abstract class JasonetteAction
    {
        public static implicit operator JasonetteAction(string trigger)
        {
            return new JasonetteRegisteredAction(trigger);
        }
    }
}