﻿// Copyright (c) Parbad. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC License, Version 3.0. See License.txt in the project root for license information.

namespace Parbad.Gateway.Pasargad.Api.Models;

public class PasargadVerifyPaymentResponseModel
{
    public bool IsSuccess { get; set; }

    public string Message { get; set; }

    public string MaskedCardNumber { get; set; }

    public string HashedCardNumber { get; set; }

    public string ShaparakRefNumber { get; set; }
}
