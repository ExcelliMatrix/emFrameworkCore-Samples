using emFrameworkCore.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGenSample
{
  public class WebAPIResult<T>
  {
    public T Result { get; set; }
    public DataResult DataResult { get; set; }
  }
}
