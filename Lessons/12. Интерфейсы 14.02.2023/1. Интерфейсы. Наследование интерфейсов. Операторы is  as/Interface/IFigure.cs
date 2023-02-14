interface IFigure
{
    void FigureType();
    void area();
    double PropA
    {
        get;
        set;
    }
}

interface IFigureAngle: IFigure
{
    void Diagonal();
    double PropB
    {
        get;
        set;
    }
}

interface IFigureRound : IFigure
{
    void Length();
}