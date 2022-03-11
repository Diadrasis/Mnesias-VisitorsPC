// This code automatically generated by TableCodeGen
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class SInfoCSV : MonoBehaviour
{

	List<RowS> rowList = new List<RowS>();
	public bool isLoaded = false;

	public bool IsLoaded()
	{
		return isLoaded;
	}

	public List<RowS> GetRowList()
	{
		return rowList;
	}

	/*public void Load(TextAsset csv)
	{
		rowList.Clear();
		string[][] grid = CsvParser2.Parse(csv.text);
		for (int i = 1; i < grid.Length; i++)
		{
			RowS row = new RowS();
			row.bodyMaterial = grid[i][0];
			row.wayOfPlaying = grid[i][1];
			row.numOfChords = grid[i][2];
			row.chords = grid[i][3];
			row.length = grid[i][4];
			row.tension = grid[i][5];
			row.density = grid[i][6];
			row.folderS = grid[i][7];
			row.audioFile = grid[i][8];

			rowList.Add(row);
		}
		isLoaded = true;
	}*/

	public int NumRows()
	{
		return rowList.Count;
	}

	public RowS GetAt(int i)
	{
		if (rowList.Count <= i)
			return null;
		return rowList[i];
	}

	public RowS Find_bodyMaterial(string find)
	{
		return rowList.Find(x => x.bodyMaterial == find);
	}
	public List<RowS> FindAll_bodyMaterial(string find)
	{
		return rowList.FindAll(x => x.bodyMaterial == find);
	}
	public RowS Find_wayOfPlaying(string find)
	{
		return rowList.Find(x => x.wayOfPlaying == find);
	}
	public List<RowS> FindAll_wayOfPlaying(string find)
	{
		return rowList.FindAll(x => x.wayOfPlaying == find);
	}
	public RowS Find_numOfChords(string find)
	{
		return rowList.Find(x => x.numOfChords == find);
	}
	public List<RowS> FindAll_numOfChords(string find)
	{
		return rowList.FindAll(x => x.numOfChords == find);
	}
	public RowS Find_chords(string find)
	{
		return rowList.Find(x => x.chords == find);
	}
	public List<RowS> FindAll_chords(string find)
	{
		return rowList.FindAll(x => x.chords == find);
	}
	public RowS Find_length(string find)
	{
		return rowList.Find(x => x.length == find);
	}
	public List<RowS> FindAll_length(string find)
	{
		return rowList.FindAll(x => x.length == find);
	}
	public RowS Find_tension(string find)
	{
		return rowList.Find(x => x.tension == find);
	}
	public List<RowS> FindAll_tension(string find)
	{
		return rowList.FindAll(x => x.tension == find);
	}
	public RowS Find_density(string find)
	{
		return rowList.Find(x => x.density == find);
	}
	public List<RowS> FindAll_density(string find)
	{
		return rowList.FindAll(x => x.density == find);
	}
	public RowS Find_folder(string find)
	{
		return rowList.Find(x => x.folderS == find);
	}
	public List<RowS> FindAll_folder(string find)
	{
		return rowList.FindAll(x => x.folderS == find);
	}
	public RowS Find_audioFile(string find)
	{
		return rowList.Find(x => x.audioFile == find);
	}
	public List<RowS> FindAll_audioFile(string find)
	{
		return rowList.FindAll(x => x.audioFile == find);
	}

}
[SerializeField]
public class RowS
{
	public string bodyMaterial;
	public string wayOfPlaying;
	public string numOfChords;
	public string chords;
	public string length;
	public string tension;
	public string density;
	public string folderS;
	public string audioFile;

}