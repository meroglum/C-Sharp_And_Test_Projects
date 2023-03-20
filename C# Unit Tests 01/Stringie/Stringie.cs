namespace Stringie
{
    public static class RemoveExtensions    // Extension Method
    {
        public static RemoveString Remove(this string source)
        {
            return new RemoveString(source);
        }
    }

    public class RemoveString
    {
        private readonly string _source;

        internal RemoveString(string source)
        {
            _source = source;
        }

        public static implicit operator string(RemoveString removeString)   // Operator Overloading
        {
            return removeString.ToString();
        }

        public override string ToString()
        {
            return _source != null ? string.Empty : null;
        }
    }
}