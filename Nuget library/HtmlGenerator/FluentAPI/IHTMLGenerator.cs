﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGenerator.Infrastructure
{
    public interface IHTMLElement
    {
        string GenerateAttributes();

        string GenerateStyles();
    }
}