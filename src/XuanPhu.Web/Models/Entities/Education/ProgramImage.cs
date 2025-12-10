namespace XuanPhu.Web.Models.Entities.Education
{
    public class ProgramImage : BaseEntity
    {
        public int EducationProgramId { get; set; }
        public EducationProgram EducationProgram { get; set; } = null!;

        public int MediaFileId { get; set; }
        public MediaFile MediaFile { get; set; } = null!;

        public int OrderIndex { get; set; }
    }
}
