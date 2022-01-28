using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventary : Singleton<Inventary>
{
    [SerializeField] int slotsNumber;
    public int getSlotsNumber => slotsNumber;
    [SerializeField] private Inventaryiten[] itentsInventary;

    private void Start()
    {
        itentsInventary = new Inventaryiten[slotsNumber];
    }
    private void AddIten(Inventaryiten toAdd, int numberOf)
    {
        if (toAdd != null)
        {
            List<int> indexes = verifyExistentIndex(toAdd.id);
            if (toAdd.isAcumulativeble == true)
            {
                for(int i = 0; i < indexes.Count; i++)
                {
                        if(itentsInventary[indexes[i]].numberOf < toAdd.maxAcumulation)
                    {
                        itentsInventary[indexes[i]].numberOf += numberOf;
                        if (itentsInventary[indexes[i]].numberOf > toAdd.maxAcumulation)
                        {
                            int diference = itentsInventary[indexes[i]].numberOf - toAdd.maxAcumulation;
                            itentsInventary[indexes[i]].numberOf = toAdd.maxAcumulation;
                            AddIten(toAdd, diference);
                        }
                    }
                }
            }
            if (numberOf == 0)
            {
                return;
            }
            else
            {

            }
        }
        else
        {
            return;
        }
    }
    
    private List<int> verifyExistentIndex(string itenID)
    {
        List<int> indexIten = new List<int>();
        for(int i = 0; i < itentsInventary.Length; i++)
        {
            if(itentsInventary[i].id == itenID)
            {
                indexIten.Add(i);
            }
           
        }
        return indexIten;
    }
    private void AddItentSlot(Inventaryiten iten, int number)
    {
        for(int i = 0; i < itentsInventary.Length; i++)
        {
            if (iten != null)
            {
                itentsInventary[i] = iten;
                itentsInventary[i].numberOf = number;
            }
        }
    }

}
