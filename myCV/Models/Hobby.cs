namespace myCV.Models
{
    public class Hobby
    {
        string name;
        string namePl;
        string description;
        string descriptionPl;

        public Hobby()
        {
            this.name = string.Empty;
            this.namePl = string.Empty;
            this.description = string.Empty;
            this.descriptionPl = string.Empty;
        }
        public Hobby(string name, string namePl, string description, string descriptionPl)
        {
            this.name = name;
            this.namePl = namePl;
            this.description = description;
            this.descriptionPl = descriptionPl;
        }

        public string getName(string lang)
        {
            return lang == "pl" ? this.namePl : this.name;
        }

        public string getDescription(string lang)
        {
            return lang == "pl" ? this.descriptionPl : this.description;
        }
    }
}
