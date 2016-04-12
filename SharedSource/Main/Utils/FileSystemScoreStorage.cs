namespace HarryPotter.Utils
{
    using System.IO;

    internal class FileSystemScoreStorage : IScoreStorage
    {
        private readonly string fileName;

        public FileSystemScoreStorage(string fileName)
        {
            this.fileName = fileName;
        }

        public int GetScore()
        {
            if (!File.Exists(this.fileName))
            {
                return 0;
            }

            using (var fileStream = new FileStream(this.fileName, FileMode.Open, FileAccess.Read))
            using (var binaryReader = new BinaryReader(fileStream))
            {
                return binaryReader.ReadInt32();
            }
        }

        public void SaveScore(int score)
        {
            using (var fileStream = new FileStream(this.fileName, FileMode.Create))
            using (var binaryWriter = new BinaryWriter(fileStream))
            {
                binaryWriter.Write(score);
            }
        }
    }
}
