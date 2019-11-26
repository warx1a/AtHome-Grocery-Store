$(document).ready(function () {
    $(".cbCategory").change(function () {
        if ($(this).is(":checked")) {
            $("#hdnCatOperation").val("add");
        } else {
            $("#hdnCatOperation").val("remove");
        }
        $("#hdnCatFilter").val($(this).val());
        $("#frmSearchFilters").submit();
    });
});