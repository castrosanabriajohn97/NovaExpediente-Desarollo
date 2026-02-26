/* EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature. */
import { format } from "date-fns";
import { es } from "date-fns/locale";

export const aplicarFormatoFecha = (f, ft = "Pp") =>
  f ? format(new Date(f), ft) : f;

export const getProp = (key, obj) => {
  if (obj.hasOwnProperty(key)) {
    return obj[key];
  }
  return null;
};
