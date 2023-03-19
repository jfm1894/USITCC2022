using System;


public class TournamentRecord
{
	public string GrandSlamID { get; set; }
    public string GrandSlamName { get; set; }
    public string WinningPlayerID { get; set; }
    public string WinningPlayerName { get; set; }
    public int WinningPlayerEarnings { get; set; }
    public TournamentRecord()
	{
        this.GrandSlamID = null;
        this.GrandSlamName = null;
        this.WinningPlayerID = null;
        this.WinningPlayerName = null;
        this.WinningPlayerEarnings = 0;
	}
}
