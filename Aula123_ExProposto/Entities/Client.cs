using System.Text;
namespace Aula123_ExProposto.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, string birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        // OVERRIDE CLIENT
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Client: ");
            sb.Append(Name);
            sb.Append(" (");
            sb.Append(BirthDate);
            sb.Append(") - ");
            sb.AppendLine(Email);

            return sb.ToString();
        }
    }
}
