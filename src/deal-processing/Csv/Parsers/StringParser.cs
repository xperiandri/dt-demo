namespace DTDemo.DealProcessing.Csv
{
    public class StringParser : IParser
    {
        private readonly char delimeter;

        public StringParser(char delimeter)
        {
            this.delimeter = delimeter;
        }

        public ParserType ParserType => ParserType.String;

        public (char?, ParserType) Parse(char character)
        {
            switch (character)
            {
                case char c when c == this.delimeter:
                    return (character, ParserType.String);
                case Symbol.Quote:
                    return (null, ParserType.Quote);
                default:
                    return (character, ParserType.String);
            }
        }
    }
}