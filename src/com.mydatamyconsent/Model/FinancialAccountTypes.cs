/*
 * My Data My Consent - Developer API
 *
 * Unleashing the power of data consent by establishing trust. The Platform Core Developer API defines a set of capabilities that can be used to request, issue, manage and update data, documents and credentials by organizations. The API can be used to request, manage and update Decentralised Identifiers, Financial Data, Health Data issue Documents, Credentials directly or using OpenID Connect flows, and verify Messages signed with DIDs and much more.
 *
 * The version of the OpenAPI document: v1
 * Contact: support@mydatamyconsent.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = com.mydatamyconsent.Client.OpenAPIDateConverter;

namespace com.mydatamyconsent.Model
{
    /// <summary>
    /// Defines FinancialAccountTypes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAccountTypes
    {
        /// <summary>
        /// Enum SavingsBankAccount for value: SavingsBankAccount
        /// </summary>
        [EnumMember(Value = "SavingsBankAccount")]
        SavingsBankAccount = 1,

        /// <summary>
        /// Enum MutualFund for value: MutualFund
        /// </summary>
        [EnumMember(Value = "MutualFund")]
        MutualFund = 2,

        /// <summary>
        /// Enum EquityShare for value: EquityShare
        /// </summary>
        [EnumMember(Value = "EquityShare")]
        EquityShare = 3,

        /// <summary>
        /// Enum NationalPensionScheme for value: NationalPensionScheme
        /// </summary>
        [EnumMember(Value = "NationalPensionScheme")]
        NationalPensionScheme = 4,

        /// <summary>
        /// Enum InsurancePolicy for value: InsurancePolicy
        /// </summary>
        [EnumMember(Value = "InsurancePolicy")]
        InsurancePolicy = 5,

        /// <summary>
        /// Enum Demat for value: Demat
        /// </summary>
        [EnumMember(Value = "Demat")]
        Demat = 6,

        /// <summary>
        /// Enum CreditCard for value: CreditCard
        /// </summary>
        [EnumMember(Value = "CreditCard")]
        CreditCard = 7,

        /// <summary>
        /// Enum Loan for value: Loan
        /// </summary>
        [EnumMember(Value = "Loan")]
        Loan = 8,

        /// <summary>
        /// Enum Bond for value: Bond
        /// </summary>
        [EnumMember(Value = "Bond")]
        Bond = 9,

        /// <summary>
        /// Enum Debenture for value: Debenture
        /// </summary>
        [EnumMember(Value = "Debenture")]
        Debenture = 10,

        /// <summary>
        /// Enum Deposit for value: Deposit
        /// </summary>
        [EnumMember(Value = "Deposit")]
        Deposit = 11,

        /// <summary>
        /// Enum GovernmentSecurity for value: GovernmentSecurity
        /// </summary>
        [EnumMember(Value = "GovernmentSecurity")]
        GovernmentSecurity = 12,

        /// <summary>
        /// Enum IndianDepositoryReceipt for value: IndianDepositoryReceipt
        /// </summary>
        [EnumMember(Value = "IndianDepositoryReceipt")]
        IndianDepositoryReceipt = 13,

        /// <summary>
        /// Enum Invit for value: Invit
        /// </summary>
        [EnumMember(Value = "Invit")]
        Invit = 14,

        /// <summary>
        /// Enum Reit for value: Reit
        /// </summary>
        [EnumMember(Value = "Reit")]
        Reit = 15,

        /// <summary>
        /// Enum PublicProvidentFund for value: PublicProvidentFund
        /// </summary>
        [EnumMember(Value = "PublicProvidentFund")]
        PublicProvidentFund = 16,

        /// <summary>
        /// Enum SystematicInvestmentPlan for value: SystematicInvestmentPlan
        /// </summary>
        [EnumMember(Value = "SystematicInvestmentPlan")]
        SystematicInvestmentPlan = 17,

        /// <summary>
        /// Enum TermDeposit for value: TermDeposit
        /// </summary>
        [EnumMember(Value = "TermDeposit")]
        TermDeposit = 18,

        /// <summary>
        /// Enum UnitLinkedInsurancePlan for value: UnitLinkedInsurancePlan
        /// </summary>
        [EnumMember(Value = "UnitLinkedInsurancePlan")]
        UnitLinkedInsurancePlan = 19,

        /// <summary>
        /// Enum RecurringDeposit for value: RecurringDeposit
        /// </summary>
        [EnumMember(Value = "RecurringDeposit")]
        RecurringDeposit = 20,

        /// <summary>
        /// Enum AlternativeInvestmentFund for value: AlternativeInvestmentFund
        /// </summary>
        [EnumMember(Value = "AlternativeInvestmentFund")]
        AlternativeInvestmentFund = 21,

        /// <summary>
        /// Enum CreditScoreReport for value: CreditScoreReport
        /// </summary>
        [EnumMember(Value = "CreditScoreReport")]
        CreditScoreReport = 22

    }

}
