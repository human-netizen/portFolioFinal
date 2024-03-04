namespace PortFolioFInal.Models
{
    public class Home
    {
        public List<Project> Projects { get; set; }
        public List<Skill> Skills { get; set; }

        public ContactModel ContactForm { get; set; } = new ContactModel();
        public LoginModel LoginModel { get; set; } = new LoginModel();

    }
}
