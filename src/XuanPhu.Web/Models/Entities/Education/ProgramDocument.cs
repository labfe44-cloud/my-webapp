namespace XuanPhu.Web.Models.Entities.Education
{
    public class ProgramDocument : BaseEntity
    {
        public int EducationProgramId { get; set; }
        public EducationProgram EducationProgram { get; set; } = null!;

        public int MediaFileId { get; set; }
        public MediaFile MediaFile { get; set; } = null!;

        public string DisplayName { get; set; } = null!;
    }
}
