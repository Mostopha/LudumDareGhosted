using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterClass
{

    public string name;    
    public Sprite topDownSprite;
    
    public Color speechColor;
    public Sprite speechBubbleSprite;


    
    #region Expressions
    
    public Sprite normalExpression;
    public Sprite happyExpression;
    public Sprite sadExpression;

    #endregion

}
