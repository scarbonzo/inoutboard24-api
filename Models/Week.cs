namespace inoutboard24_api.Models
{
    public class Week
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Year { get; set; }
        public int WeekNumber { get; set; }

        public int MondayStatusId { get; set; }
        public int TuesdayStatusId { get; set; }
        public int WednesdayStatusId { get; set; }
        public int ThursdayStatusId { get; set; }
        public int FridayStatusId { get; set; }

        public int MondayStartHour { get; set; }
        public int TuesdayStartHour { get; set; }
        public int WednesdayStartHour { get; set; }
        public int ThursdayStartHour { get; set; }
        public int FridayStartHour { get; set; }

        public int MondayEndHour { get; set; }
        public int TuesdayEndHour { get; set; }
        public int WednesdayEndHour { get; set; }
        public int ThursdayEndHour { get; set; }
        public int FridayEndHour { get; set; }

        public int MondayNotes { get; set; }
        public int TuesdayNotes { get; set; }
        public int WednesdayNotes { get; set; }
        public int ThursdayNotes { get; set; }
        public int FridayNotes { get; set; }

        public int WeekNotes { get; set; }
    }
}
