namespace WEB.API.Attributes
{
    public class PrivilegeAttribute : Attribute
    {
        public PrivilegeAttribute() { }
    }

    public class FirstAttribute : Attribute
    {
        public FirstAttribute(string name)
        {
            Name = name;
            Console.WriteLine(Name);
        }
        public string Name { get; private set; }
    }
}
