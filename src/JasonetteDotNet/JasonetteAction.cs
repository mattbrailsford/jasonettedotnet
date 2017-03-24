namespace JasonetteDotNet
{
    public abstract class JasonetteAction : JasonetteEntity
    {
        public static implicit operator JasonetteAction(string trigger)
        {
            return new JasonetteRegisteredAction(trigger);
        }
    }
}