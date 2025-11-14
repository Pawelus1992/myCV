namespace myCV.Models
{
    public class Job
    {
        string positionName;
        string positionNamePl;
        string description;
        string descriptionPl;
        DateOnly startDate;
        DateOnly endDate;
        string companyName;

        public Job()
        {
            this.positionName = string.Empty;
            this.positionNamePl = string.Empty;
            this.description = string.Empty;
            this.descriptionPl = string.Empty;
            this.startDate = new DateOnly();
            this.endDate = new DateOnly();
            this.companyName = string.Empty;
        }

        public Job(string positionName, string positionNamePl, string description, string descriptionPl, DateOnly startDate, DateOnly endDate, string companyName)
        {
            this.positionName = positionName;
            this.positionNamePl = positionNamePl;
            this.description = description;
            this.descriptionPl = descriptionPl;
            this.startDate = startDate;
            this.endDate = endDate;
            this.companyName = companyName;
        }

        public string getPositionName(string lang)
        {
            return lang == "pl" ? this.positionNamePl : this.positionName;
        }
        public string getDescription(string lang)
        {
            return lang == "pl" ? this.descriptionPl : this.description;
        }
        public string getStartDate()
        {
            return this.startDate.ToString("yyyy/MM/dd");
        }
        public string getEndDate()
        {
            return this.endDate.ToString("yyyy/MM/dd");
        }

        public string getCompanyName()
        {
            return this.companyName;
        }
    }
}
