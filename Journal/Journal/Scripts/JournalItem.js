(function () {
    console.log('check input data')
    const journalDetailsForms = document.querySelectorAll('.requires-validation')
    const journalForms = document.querySelectorAll('.journal-requires-validation')

    Array.from(journalDetailsForms)
        .forEach(function (journalDetailsForms) {
            const element = document.getElementById("submitDetails");
            element.addEventListener('click', function (event) {
                if (!journalDetailsForms.checkValidity()) {
                    console.log('true')
                    event.preventDefault()
                    event.stopPropagation()
                } else {
                    console.log('false')
                    addDetails()
                    journalDetailsForms.classList.remove('was-validated')
                }
                journalDetailsForms.classList.add('was-validated')
            }, false)
        })

    Array.from(journalForms)
        .forEach(function (journalForms) {
            const element = document.getElementById("submitJournal");
            element.addEventListener('click', function (event) {
                if (!journalForms.checkValidity()) {
                    event.preventDefault()
                    event.stopPropagation()
                } else {
                    saveJournal()
                    journalForms.classList.remove('was-validated')
                }

                journalForms.classList.add('was-validated')
            }, false)
        })
})()

journal = {
    vcode: '',
    date: '',
    payee: '',
    journalDetailsArr: []
}


function addDetails() {
    sign = $('#journalSign').val();
    type = $('#journalType').val();
    account = $('#journalAccount').val();
    reftype = $('#journalRefType').val();
    refno = $('#journalRefNo').val();
    amount = $('#journalAmount').val();
    costcenter = $('#journalCostCenter').val();
    narration = $('#journalNarration').val();

    journalDetails = {
        'sign': sign,
        'type': type,
        'account': account,
        'reftype': reftype,
        'refno': refno,
        'amount': amount,
        'costcenter': costcenter,
        'narration': narration,
    }
    trcontent = '<tr><th>' + sign + '</th><th>' + type + '</th><th>' + reftype + '</th><th>' + refno + '</th><th>' + costcenter + '</th><th>' + amount + '</th></tr>'
    $('#lineTable tr:last').after(trcontent);
    journal.journalDetailsArr.push(journalDetails)
    console.log(journal)
    $('#exampleModal').modal('hide');

    $('#journalAccount').val('');
    $('#journalRefNo').val('');
    $('#journalAmount').val('');
    $('#journalCostCenter').val('');
    $('#journalNarration').val('');
}



function saveJournal() {
    if (journal.journalDetailsArr.length == 0) {
        alert("Atleast 1 journal")
        return;
    }

    journal.vcode = $('#voucher_code').val();
    journal.date = $('#date').val();
    journal.payee = $('#payee').val();
    af = { "enddata": JSON.stringify(journal) }

    $.ajax({
        type: "get",
        url: "../journal/submit",
        dataType: 'json',
        data: { "enddata": JSON.stringify(journal) },
        success: function (response) {
            if (response.result == 200) {
                $('#pVcode').append(journal.vcode)
                $('#pDate').append(journal.date)
                $('#pPayee').append(journal.payee)

                journal.journalDetailsArr.forEach(function (item) {
                    sign = item.sign
                    type = item.type
                    account = item.account
                    reftype = item.reftype
                    refno = item.refno
                    amount = item.amount
                    costcenter = item.costcenter
                    narration = item.narration
                    trcontent = '<tr><th>' + sign + '</th><th>' + type + '</th><th>' + account + '</th><th>' + reftype + '</th><th>' + refno + '</th><th>' + amount + '</th><th>' + costcenter + '</th><th>' + narration + '</th></tr>'
                    $('#printModal tr:last').after(trcontent);
                })
                $('#printModal').modal('show');

            }
        }
    })
}

