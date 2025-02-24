<Query Kind="Statements">
  <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
</Query>

class Personne
{
	
	private string _nom;

	public Personne(string nom)
	{
		
		SetNom(nom);
		
		/*
		this._nom = nom;*/
	}

	//getters
	public string GetNom() => _nom;

	[MemberNotNull(nameof(_nom))]
	public void SetNom(string nom)
	{
		if(string.IsNullOrWhiteSpace(nom))
			throw new ArgumentException();
		_nom = nom;
	}


}