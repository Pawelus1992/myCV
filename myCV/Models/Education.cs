namespace myCV.Models
{
    public class Education
    {
        string schoolName;
        string schoolNamePl;
        string degree;
        string degreePl;
        DateOnly startDate;
        DateOnly endDate;
        string description;
        string descriptionPl;
        string website;
        public Education()
        {
            this.schoolName = string.Empty;
            this.schoolNamePl = string.Empty;
            this.degree = string.Empty;
            this.degreePl = string.Empty;
            this.startDate = new DateOnly();
            this.endDate = new DateOnly();
            this.description = string.Empty;
            this.descriptionPl = string.Empty;
            this.website = string.Empty;
        }

        public Education(string schoolName, string schoolNamePl, string degree, string degreePl, DateOnly startDate, DateOnly endDate, string description, string descriptionPl, string website)
        {
            this.schoolName = schoolName;
            this.schoolNamePl = schoolNamePl;
            this.degree = degree;
            this.degreePl = degreePl;
            this.startDate = startDate;
            this.endDate = endDate;
            this.description = description;
            this.descriptionPl = descriptionPl;
            this.website = website;
        }

        public string getSchoolName(string lang)
        {
            return lang == "pl" ? this.schoolNamePl : this.schoolName;
        }

        public string getDegree(string lang)
        {
            return lang == "pl" ? this.degreePl : this.degree;
        }

        public string getStartDate()
        {
            return this.startDate.ToString("yyyy/MM/dd");
        }

        public string getEndDate()
        {
            return this.endDate.ToString("yyyy/MM/dd");
        }

        public string getDescription(string lang)
        {
            return lang == "pl" ? this.descriptionPl : this.description;
        }

        public string getWebsite()
        {
            return this.website;
        }
    }
}