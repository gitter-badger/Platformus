﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Data.Abstractions;
using Microsoft.AspNet.Mvc;

namespace Platformus.Barebone.Controllers
{
  public abstract class ControllerBase : Controller, IHandler
  {
    public IStorage Storage { get; private set; }

    public ControllerBase(IStorage storage)
    {
      this.Storage = storage;
    }

    protected RedirectResult CreateRedirectToSelfResult()
    {
      return this.Redirect(this.Request.Path.Value + this.Request.QueryString.Value);
    }
  }
}