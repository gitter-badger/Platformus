﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Platformus.Barebone.Backend;
using Platformus.Globalization.Backend.ViewModels;

namespace Platformus.Content.Backend.ViewModels.Members
{
  public class CreateOrEditViewModel : ViewModelBase
  {
    public int? Id { get; set; }
    public int ClassId { get; set; }

    [Display(Name = "Tab")]
    public int? TabId { get; set; }
    public IEnumerable<Option> TabOptions { get; set; }

    [Display(Name = "Code")]
    [Required]
    [StringLength(32)]
    public string Code { get; set; }

    [Display(Name = "Name")]
    [Required]
    [StringLength(64)]
    public string Name { get; set; }

    [Display(Name = "Display in list")]
    public bool DisplayInList { get; set; }

    [Display(Name = "Position")]
    public int? Position { get; set; }

    [Display(Name = "Relation class")]
    public int? RelationClassId { get; set; }
    public IEnumerable<Option> RelationClassOptions { get; set; }

    [Display(Name = "Is relation single parent")]
    public bool IsRelationSingleParent { get; set; }

    [Display(Name = "Property data type")]
    public int? PropertyDataTypeId { get; set; }
    public IEnumerable<Option> PropertyDataTypeOptions { get; set; }
  }
}