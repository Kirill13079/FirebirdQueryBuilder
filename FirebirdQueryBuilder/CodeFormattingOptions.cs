namespace FirebirdQueryBuilder
{
    public sealed class CodeFormattingOptions
    {
        public CaseEnum Identifiers { get; set; } = CaseEnum.LowerCase;

        public CaseEnum Keywords { get; set; } = CaseEnum.LowerCase;
    }
}
