using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayWords : MonoBehaviour
{
	public TMP_Text TText;
	public ExcelReader excelReader;
	
	// Start is called before the first frame update
	void Start()
	{
		excelReader = GetComponent<ExcelReader>();
		StartCoroutine(IterateWords());
	}
	
	IEnumerator IterateWords()
	{
		for(int i = 0; i < excelReader.excelContentList.Count; i++)
		{
			TText.text = excelReader.excelContentList[i];
			yield return new WaitForSeconds(1.5f);
		}
	}
}
