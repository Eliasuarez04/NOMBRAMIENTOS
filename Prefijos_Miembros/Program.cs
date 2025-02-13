//Código Sucio

class Player
{
    private int m_playerScore;
    
    public void SetScore(int p_score)
    {
        m_playerScore = p_score;
    }
}


//Código Limpio
class Player
{
    private int score;

    public void SetScore(int score)
    {
        this.score = score;
    }
}