using System;
using System.Collections;
using System.Collections.Generic;
namespace Inheritance;


public class IEnum : IEnumerable<float>{
public Random random = new Random();

public IEnumerator<float> GetEnumerator(){
int countBelow =0;
while(true){
  float amount = (float)random.NextDouble();
  yield return amount;

  if(amount<= 0.5){
    countBelow++;
  }else{
    countBelow=0;
  }
  if(countBelow>=3){
    throw new Except("3 numbers in a row were last than .5");
      }
    }
  } 
  IEnumerator IEnumerable.GetEnumerator(){
    return GetEnumerator();
  }
}