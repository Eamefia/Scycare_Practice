/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor.RichTextEditor;
using Microsoft.AspNetCore.Components;
using Scylab.DataItems;
using Syncfusion.Blazor.RichTextEditor;
using Scylab.Models;

namespace Scylab.Pages
{
    public partial class AddItem
    {
        [Inject]
        public IRepository _irepository { get; set; }
        [Inject]
        public NavigationManager NavManager { get; set; }

      private List<ToolbarItemModel> Tools = new List<ToolbarItemModel>()
{
    new ToolbarItemModel() { Command = ToolbarCommand.Bold },
        new ToolbarItemModel() { Command = ToolbarCommand.Italic },
        new ToolbarItemModel() { Command = ToolbarCommand.Underline },
        new ToolbarItemModel() { Command = ToolbarCommand.StrikeThrough },
        new ToolbarItemModel() { Command = ToolbarCommand.FontName },
        new ToolbarItemModel() { Command = ToolbarCommand.FontSize },
        new ToolbarItemModel() { Command = ToolbarCommand.FontColor },
        new ToolbarItemModel() { Command = ToolbarCommand.BackgroundColor },
        new ToolbarItemModel() { Command = ToolbarCommand.LowerCase },
        new ToolbarItemModel() { Command = ToolbarCommand.UpperCase },
        new ToolbarItemModel() { Command = ToolbarCommand.SuperScript },
        new ToolbarItemModel() { Command = ToolbarCommand.SubScript },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.Formats },
        new ToolbarItemModel() { Command = ToolbarCommand.Alignments },
        new ToolbarItemModel() { Command = ToolbarCommand.OrderedList },
        new ToolbarItemModel() { Command = ToolbarCommand.UnorderedList },
        new ToolbarItemModel() { Command = ToolbarCommand.Outdent },
        new ToolbarItemModel() { Command = ToolbarCommand.Indent },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.CreateLink },
        new ToolbarItemModel() { Command = ToolbarCommand.Image },
        new ToolbarItemModel() { Command = ToolbarCommand.CreateTable },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.ClearFormat },
        new ToolbarItemModel() { Command = ToolbarCommand.Print },
        new ToolbarItemModel() { Command = ToolbarCommand.SourceCode },
        new ToolbarItemModel() { Command = ToolbarCommand.FullScreen },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.Undo },
        new ToolbarItemModel() { Command = ToolbarCommand.Redo }
  };
    public double GrossAmount{

        get{
            double gross_amount = 0;
            string tax = Items.Tax;
            string discount = Items.Discount;
            double tax_vat = 0.17;
            double tax_direct = 0.15;
            double discount_chris = 0.25;
            double discount_east = 0.18;
            double net_amount = 0;
            double calc_amount = 0;
            try{
                if (tax == "VAT" && discount == "Chrismass")
                {
                    net_amount = Convert.ToDouble(Items.NetAmount);
                    calc_amount = (net_amount) + (net_amount * Convert.ToDouble(tax_vat));
                    gross_amount = (calc_amount) - (calc_amount * Convert.ToDouble(discount_chris));
                }else if (tax == "VAT" && discount == "Fast sales"){
                       net_amount = Convert.ToDouble(Items.NetAmount);
                       calc_amount = (net_amount) + (net_amount * Convert.ToDouble(tax_vat));
                       gross_amount = (calc_amount) - (calc_amount * Convert.ToDouble(discount_east));
                }else if (tax == "Direct Payment" && discount == "Fast sales"){
                        net_amount = Convert.ToDouble(Items.NetAmount);
                        calc_amount = (net_amount) + (net_amount * Convert.ToDouble(tax_direct));
                        gross_amount = (calc_amount) - (calc_amount * Convert.ToDouble(discount_east));
                }else if (tax == "Direct Payment" && discount == "Chismass"){
                          net_amount = Convert.ToDouble(Items.NetAmount);
                          calc_amount = (net_amount) + (net_amount * Convert.ToDouble(tax_direct));
                          gross_amount = (calc_amount) - (calc_amount * Convert.ToDouble(discount_chris));
                }
            }
            catch(Exception e){
                gross_amount = 0;
            }
            return gross_amount;
        }
    }

    protected ItemModel Items {get; set;} = new ItemModel();
    public void FormSubmitted(){
        Items.GrossAmount = GrossAmount;
        try{
        ItemModel new_item = new ItemModel{
            Id = System.Guid.NewGuid(),
            ItemName =  Items.ItemName,
            ItemQuantity =  Items.ItemQuantity,
            NetAmount = Items.NetAmount,
            GrossAmount =  Items.GrossAmount,
            ItemCategory = Items.ItemCategory,
            Unit = Items.Unit,
            Tax =  Items.Tax,
            Discount = Items.Discount
        };
        _irepository.AddItem(new_item);
        NavManager.NavigateTo("/add_all");

        }
        catch(Exception ex){
            
        }
    }
    }
}*/
