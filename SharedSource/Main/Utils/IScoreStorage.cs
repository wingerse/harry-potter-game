namespace HarryPotter.Utils
{
    internal interface IScoreStorage
    {
        int GetScore();
        void SaveScore(int score);
    }
}
