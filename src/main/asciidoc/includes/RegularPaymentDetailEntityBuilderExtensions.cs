    public static class RegularPaymentDetailEntityBuilderExtensions
    {
        public static void Build(this EntityTypeBuilder<RegularPaymentDetailEntity> builder)
        {
            builder.ToTable("regular_payment_detail");

            builder.HasComment("Данная сущность хранит в себе детали регулярных переводов");

            builder.HasKey(x => x.UnId);

            builder.Property(x => x.UnId)
                .HasColumnName("un_id")
                .HasComment("Идентификатор ППП");
                
            builder.Property(x => x.Cuid)
                .HasColumnName("cuid")
                .HasComment("Идентификатор клиента");
                
            builder.Property(x => x.CardNumber)
                .HasColumnName("card_number")
                .HasComment("Номер карты списания");
                
            builder.Property(x => x.AccountNumber)
                .HasColumnName("account_number")
                .HasComment("Счет списания")
                .IsRequired();
            
            builder.Property(x => x.Name)
                .HasColumnName("name")
                .HasComment("Название ППП")
                .IsRequired();
            
            builder.Property(x => x.Amount)
                .HasColumnName("amount")
                .HasComment("Сумма операции");
                
            builder.Property(x => x.Currency)
                .HasColumnName("currency")
                .HasComment("Валюта операции")
                .IsRequired();
            
            builder.Property(x => x.AccountTo)
                .HasColumnName("account_to")
                .HasComment("Счет списания").
                IsRequired();
            
            builder.Property(x => x.PaymentPurpose)
                .HasColumnName("payment_purpose")
                .HasComment("Назначение платежа");
                
            builder.Property(x => x.Recipient)
                .HasColumnName("recipient")
                .HasComment("Назначение платежа");
                
            builder.Property(x => x.Bic)
                .HasColumnName("bic")
                .HasComment("БИК банка получателя");
                
            builder.Property(x => x.Inn)
                .HasColumnName("inn")
                .HasComment("ИНН получателя");
                
            builder.Property(x => x.Kpp)
                .HasColumnName("kpp")
                .HasComment("КПП получателя");
                
            builder.Property(x => x.CorrAccount)
                .HasColumnName("corr_account")
                .HasComment("Кор счет банка получателя");
                
            builder.Property(x => x.TaxAmount)
                .HasColumnName("tax_amount")
                .HasComment("Сумма налогов");

            builder.Property(x => x.Uip)
                .HasColumnName("uip")
                .HasComment("УИН/УИП");
        }
    }
}
