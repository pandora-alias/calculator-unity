using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calculator : MonoBehaviour
{
    // Start is called before the first frame update
	public Text InputField;
	float result, inp1, inp2;
	string oper, output;
	bool calculate;
	
	/*void Start(){
		InputField=Text.Find("Textt");
	}*/
	
	public void getNo(int val)
    {
        Debug.Log($" check val: {val}");
       /* if (!string.IsNullOrEmpty(temp))
        {
            if (temp.Length < 10)
                temp+= val;
		}
        else
            temp = val.ToString();*/
        InputField.text = $"{val}";
    }
	
	
	public void getOperator(string val)
    {
        Debug.Log($" ClickOperation val: {val}");
        /*if (_input == 0)
        {
            SetCurrentInput();    
            _operation = val;
        }
        else
        {
            if (_equalIsPressed)
            {
                _equalIsPressed = false;
                _operation = val;
                _input2 = 0;
            }
            else
            {
                if (_operation.Equals(val,StringComparison.OrdinalIgnoreCase))
                {
                    Calculate();    
                }
                else
                {
                    _operation = val;
                    _input2 = 0;
                }    
            }
        }*/
    }
	
	public void getEqual(string val){
		Debug.Log($" ClickEqual val: {val}");
	}
	public void getDecimal(string val){
		Debug.Log($" ClickEqual val: {val}");
	}
	


    // Update is called once per frame
    void Update()
    {
        
    }
}/*

    #region Fields
    public TextMeshProUGUI InputText;
    private float _result;
    private float _input;
    private float _input2;
    private string _operation;
    private string _currentInput;
    private bool _equalIsPressed;
    #endregion Fields
    
    #region Methods
    public void ClickNumber(int val)
    {
        Debug.Log($" check val: {val}");
        if (!string.IsNullOrEmpty(_currentInput))
        {
            if (_currentInput.Length < 10)
            {
                _currentInput += val;
            }
        }
        else
        {
            _currentInput = val.ToString();
        }
        InputText.text = $"{_currentInput}";
    }
    
    public void ClickOperation(string val)
    {
        Debug.Log($" ClickOperation val: {val}");
        if (_input == 0)
        {
            SetCurrentInput();    
            _operation = val;
        }
        else
        {
            if (_equalIsPressed)
            {
                _equalIsPressed = false;
                _operation = val;
                _input2 = 0;
            }
            else
            {
                if (_operation.Equals(val,StringComparison.OrdinalIgnoreCase))
                {
                    Calculate();    
                }
                else
                {
                    _operation = val;
                    _input2 = 0;
                }    
            }
        }
    }
    
    public void ClickEqual(string val)
    {
        Debug.Log($" ClickEqual val: {val}");
        Calculate();
        _equalIsPressed = true;
    }

    private void Calculate()
    {
        if (_input != 0 && !string.IsNullOrEmpty(_operation) )
        {
            SetCurrentInput();
            switch (_operation)
            {
                case "+":
                    _result = _input + _input2;
                    break;
                case "-":
                    _result = _input - _input2;
                    break;
                case "*":
                    _result = _input * _input2;
                    break;
                case "/":
                    _result = _input / _input2;
                    break;
            }
            
            // show the result
            InputText.SetText(_result.ToString());
            
            // save the last result for next calculation
            _input = _result;
        }
    }

    private void SetCurrentInput()
    {
        if (!string.IsNullOrEmpty(_currentInput))
        {
            if (_input==0)
            {
                _input = int.Parse(_currentInput);
            }
            else
            {
                _input2 = int.Parse(_currentInput);
            }
            _currentInput = "";    
        }
    }

    // clear all the inputs
    public void ClearInput()
    {
        _currentInput= "";
        _input = 0;
        _input2 = 0;
        _result = 0;
        InputText.SetText("");
    }
    #endregion Methods
}*/